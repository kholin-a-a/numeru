using System;

namespace Numeru.Services
{
    public interface INumberService
    {
        int FromDate(DateTime dateTime);

        string Describe(int num);
    }
}
