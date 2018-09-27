﻿using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MoipCSharp.Controllers
{
    //Saldos - Balances
    public partial class BalancesController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static BalancesController instance = null;
        internal static BalancesController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new BalancesController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        //Consultar Saldos - Consult Balances
        public async Task<List<BalanceResponse>> Consult()
        {
            HttpResponseMessage response = await ClientInstance.GetAsync("v2/balances");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<List<BalanceResponse>>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
