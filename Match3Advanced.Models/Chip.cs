using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models
{
    public class Chip : IOnField
    {
        public ChipImageType ChipImageType { get; set; }
        public bool IsVerticalBonus { get; set; }
        public bool IsHorizontalBonus { get; set; }
        public string FileName { get; set; }
        public IOnChip OnChip { get; set; }
        public bool isSuperstar()
        {
            return ChipImageType == ChipImageType.SUPERSTAR;
        }

        public Chip(ChipImageType chipImageType, bool isVerticalBonus, bool isHorizontalBonus)
        {
            if (isVerticalBonus)
            {
                switch (chipImageType)
                {
                    case ChipImageType.T1:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/10.png";
                        break;
                    case ChipImageType.T2:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/11.png";
                        break;
                    case ChipImageType.T3:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/12.png";
                        break;
                    case ChipImageType.T4:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/13.png";
                        break;
                    case ChipImageType.T5:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/14.png";
                        break;
                    case ChipImageType.T6:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/15.png";
                        break;
                    case ChipImageType.T7:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/16.png";
                        break;
                    case ChipImageType.T8:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/17.png";
                        break;
                    case ChipImageType.T9:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/18.png";
                        break;
                }
            }
            else if (isHorizontalBonus)
            {
                switch (chipImageType)
                {
                    case ChipImageType.T1:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/19.png";
                        break;
                    case ChipImageType.T2:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/20.png";
                        break;
                    case ChipImageType.T3:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/21.png";
                        break;
                    case ChipImageType.T4:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/22.png";
                        break;
                    case ChipImageType.T5:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/23.png";
                        break;
                    case ChipImageType.T6:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/24.png";
                        break;
                    case ChipImageType.T7:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/25.png";
                        break;
                    case ChipImageType.T8:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/26.png";
                        break;
                    case ChipImageType.T9:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/27.png";
                        break;
                }
            }
            else
            {
                switch (chipImageType)
                {
                    case ChipImageType.T1:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/1.png";
                        break;
                    case ChipImageType.T2:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/2.png";
                        break;
                    case ChipImageType.T3:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/3.png";
                        break;
                    case ChipImageType.T4:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/4.png";
                        break;
                    case ChipImageType.T5:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/5.png";
                        break;
                    case ChipImageType.T6:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/6.png";
                        break;
                    case ChipImageType.T7:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/7.png";
                        break;
                    case ChipImageType.T8:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/8.png";
                        break;
                    case ChipImageType.T9:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/9.png";
                        break;
                    case ChipImageType.SUPERSTAR:
                        FileName = @"/Match3Advanced.DesktopClient;component/images/28.png";
                        break;
                }
            }
        }
    }
}
