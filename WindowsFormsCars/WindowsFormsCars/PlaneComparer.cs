using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class PlaneComparer : IComparer<APlane>
    {
        public int Compare(APlane x, APlane y)
        {
            if(x.GetType().Name != y.GetType().Name)
            {
                return x.GetType().FullName.CompareTo(y.GetType().FullName);
            }

            if(x.GetType() == y.GetType() && x is RadarPlane)
            {
                return ComparerRadarPlane((RadarPlane)x, (RadarPlane)y);
            }

            if (x.GetType() == y.GetType() && x is Plane)
            {
                return ComparerPlane((Plane)x, (Plane)y);
            }

            return 0;
        }

        private int ComparerPlane(Plane x, Plane y)
        {
            if (x.MainColor.R != y.MainColor.R)
            {
                return x.MainColor.R.CompareTo(y.MainColor.R);
            }

            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }

            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }

            return 0;
        }

        private int ComparerRadarPlane(RadarPlane x, RadarPlane y)
        {
            var res = ComparerPlane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Engine != y.Engine)
            {
                return x.Engine.CompareTo(y.Engine);
            }
            if (x.Radar != y.Radar)
            {
                return x.Radar.CompareTo(y.Radar);
            }
            if (x.Antenns != y.Antenns)
            {
                return x.Antenns.CompareTo(y.Antenns);
            }
            return 0;
        }
    }
}
