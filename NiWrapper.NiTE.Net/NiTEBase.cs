﻿/*
   Copyright (C) 2013 Soroush Falahati - soroush@falahati.net

   This library is free software; you can redistribute it and/or
   modify it under the terms of the GNU Lesser General Public
   License as published by the Free Software Foundation; either
   version 2.1 of the License, or (at your option) any later version.

   This library is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
   Lesser General Public License for more details.

   You should have received a copy of the GNU Lesser General Public
   License along with this library; if not, write to the Free Software
   Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
   */
namespace NiTEWrapper
{
    #region

    using System;

    #endregion

    // ReSharper disable once InconsistentNaming
    public abstract class NiTEBase
    {
        #region Public Properties

        public IntPtr Handle { get; protected set; }

        // ReSharper disable once MemberCanBeProtected.Global
        public bool IsValid
        {
            get
            {
                return !this.Handle.Equals(IntPtr.Zero);
            }
        }

        #endregion

        #region Public Methods and Operators

        public bool Equals(NiTEBase obj)
        {
            return this.Handle == obj.Handle;
        }

        public bool Equals(IntPtr obj)
        {
            return this.Handle == obj;
        }

        #endregion
    }
}