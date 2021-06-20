using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseAndLiskov
{
     class Square :REctangle
    {

		public override  void setWidth(int width)
		{
			m_width = width;
			m_height = width;
		}

		public override void setHeight(int height)
		{
			m_width = height;
			m_height = height;
		}
	}
}
