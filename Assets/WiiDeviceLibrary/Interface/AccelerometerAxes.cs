//    Copyright 2009 Wii Device Library authors
//
//    This file is part of Wii Device Library.
//
//    Wii Device Library is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    Wii Device Library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with Wii Device Library.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Text;

namespace WiiDeviceLibrary
{
    public class AccelerometerAxes<T>
    {
        private T _X;
        public T X
        {
            get { return _X; }
            set { _X = value; }
        }

        private T _Y;
        public T Y
        {
            get { return _Y; }
            set { _Y = value; }
        }

        private T _Z;
        public T Z
        {
            get { return _Z; }
            set { _Z = value; }
        }

        public AccelerometerAxes()
            : this(default(T), default(T), default(T))
        {
        }

        public AccelerometerAxes(T x, T y, T z)
        {
            _X = x;
            _Y = y;
            _Z = z;
        }
    }
}
