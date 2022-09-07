using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    internal class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Saves a bew oruze ti tge database
        /// </summary>
        /// <param name="model">The prize info.</param>
        /// <returns>The prize info, including the uniqe id</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
