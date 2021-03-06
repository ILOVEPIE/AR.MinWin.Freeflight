﻿/* ARDrone Control .NET - An application for flying the Parrot AR drone in Windows.
 * Copyright (C) 2010 Thomas Endres, Stephen Hobley, Julien Vinel
 * 
 * This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; either version 3 of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along with this program; if not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ARDrone;
using ARDrone.Control;

namespace AviationInstruments
{
    public class InstrumentsManager
    {
        private ARDroneControl arDroneControl;
        private List<InstrumentControl> instrumentList;

        readonly object stateLock = new object();
        bool shouldThreadBeTerminated = false;

        public InstrumentsManager(ARDroneControl arDroneControl)
        {
            this.arDroneControl = arDroneControl;
            instrumentList = new List<InstrumentControl>();
        }

        public void addInstrument(InstrumentControl instrumentControl)
        {
            this.instrumentList.Add(instrumentControl);
        }

        public void startManage()
        {
            lock (stateLock)
            {
                shouldThreadBeTerminated = false;
            }

            Thread workerThread = new Thread(this.manage);
            workerThread.Start();
        }

        public void stopManage()
        {
            lock (stateLock)
            {
                shouldThreadBeTerminated = true;
            }
        }

        private void manage()
        {
            bool localStop = false;
            lock (stateLock)
            {
                localStop = shouldThreadBeTerminated;
            }

            while (!localStop)
            {
                lock (stateLock)
                {
                    localStop = shouldThreadBeTerminated;
                }
                this.updateInstruments();
                Thread.Sleep(100);
            }
        }

        private void updateInstruments()
        {
            if (this.arDroneControl.IsConnected)
            {
                ARDrone.Control.ARDroneControl.DroneData droneData = arDroneControl.GetCurrentDroneData();
                foreach (InstrumentControl instrumentControl in instrumentList)
                {
                    try
                    {
                        switch (instrumentControl.GetType().Name)
                        {
                            case "AttitudeIndicatorInstrumentControl":
                                updateInstrument((AttitudeIndicatorInstrumentControl)instrumentControl, droneData);
                                break;

                            case "AltimeterInstrumentControl":
                                updateInstrument((AltimeterInstrumentControl)instrumentControl, droneData);
                                break;

                            case "HeadingIndicatorInstrumentControl":
                                updateInstrument((HeadingIndicatorInstrumentControl)instrumentControl, droneData);
                                break;
                            case "VerticalSpeedIndicatorInstrumentControl":
                                updateInstrument((VerticalSpeedIndicatorInstrumentControl)instrumentControl, droneData);
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        this.stopManage();
                    }
                }
            }
        }

        private void updateInstrument(AttitudeIndicatorInstrumentControl control, ARDrone.Control.ARDroneControl.DroneData droneData)
        {
            control.Invoke((MethodInvoker)delegate
            {

                control.SetAttitudeIndicatorParameters((droneData.Theta / 1000), -(droneData.Phi / 1000));
            });
        }

        private void updateInstrument(AltimeterInstrumentControl control, ARDrone.Control.ARDroneControl.DroneData droneData)
        {
            control.Invoke((MethodInvoker)delegate
            {

                control.SetAlimeterParameters(droneData.Altitude);
            });
        }

        private void updateInstrument(HeadingIndicatorInstrumentControl control, ARDrone.Control.ARDroneControl.DroneData droneData)
        {
            control.Invoke((MethodInvoker)delegate
            {
                // Psi range -180..0..180 but heading indicator require 0..360
                if (droneData.Psi > 0)
                {
                    control.SetHeadingIndicatorParameters(Convert.ToInt32(droneData.Psi / 1000));
                }
                else
                {
                    control.SetHeadingIndicatorParameters(360 + Convert.ToInt32(droneData.Psi / 1000));
                }

            });
        }

        private void updateInstrument(VerticalSpeedIndicatorInstrumentControl control, ARDrone.Control.ARDroneControl.DroneData droneData)
        {
            control.Invoke((MethodInvoker)delegate
            {

                control.SetVerticalSpeedIndicatorParameters(Convert.ToInt32(droneData.vZ));
            });
        }
    }
}
