using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseAndLiskov
{
    class REctangle
    {
        protected int m_width;
        protected int m_height;

        public virtual void setWidth(int width)
        {
            m_width = width;
        }

        public virtual void setHeight(int height)
        {
            m_height = height;
        }

        public int getArea()
        {
            return m_width * m_height;
        }

    }


}
