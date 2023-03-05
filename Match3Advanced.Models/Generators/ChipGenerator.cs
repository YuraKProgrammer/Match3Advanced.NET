using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models.Generators
{
    public class ChipGenerator : IChipGenerator
    {
        Random Random = new Random();
        public Chip GenerateChip()
        {
            return new Chip(GetChipType(), false, false);
        }

        public ChipImageType GetChipType()
        {
            var c = Random.Next(1, 9);
            switch (c)
            {
                case 1:
                    return ChipImageType.T1;
                    break;
                case 2:
                    return ChipImageType.T2;
                    break;
                case 3:
                    return ChipImageType.T3;
                    break;
                case 4:
                    return ChipImageType.T4;
                    break;
                case 5:
                    return ChipImageType.T5;
                    break;
                case 6:
                    return ChipImageType.T6;
                    break;
                case 7:
                    return ChipImageType.T7;
                    break;
                case 8:
                    return ChipImageType.T8;
                    break;
                case 9:
                    return ChipImageType.T9;
                    break;
            }
            return ChipImageType.T1;
        }
    }
}
