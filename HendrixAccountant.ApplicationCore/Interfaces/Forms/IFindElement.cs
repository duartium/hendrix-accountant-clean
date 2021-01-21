using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Forms
{
    public interface IFindElement
    {
        void Selected(ISaleElement entity);
    }
}
