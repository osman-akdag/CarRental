using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                //Kurala uymayan kuralı döndür.
                if (!logic.Success)
                {
                    return logic;
                }
            }

            return null;
        }

        //public static List<IResult> Run(params IResult[] logics)
        //{
        //    List<IResult> errorResults = new List<IResult>();   
        //    foreach (var logic in logics)
        //    {
        //        //Kurala uymayan kuralı döndür.
        //        if (!logic.Success)
        //        {
        //            errorResults.Add(logic);
        //        }
        //    }

        //    return errorResults;
        //}
    }
}
