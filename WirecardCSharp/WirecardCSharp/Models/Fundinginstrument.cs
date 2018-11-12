using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Fundinginstrument
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Creditcard creditCard { get => CreditCard; set => CreditCard = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string method { get => Method; set => Method = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string brand { get => Brand; set => Brand = value; }
    }
    public partial class Fundinginstrument
    {
        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Method { get; set; }
        [JsonProperty("creditCard", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Creditcard CreditCard { get; set; }
        [JsonProperty("brand", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Brand { get; set; }
        [JsonProperty("boleto", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Boleto Boleto { get; set; }
        [JsonProperty("onlineBankDebit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Onlinebankdebit OnlineBankDebit { get; set; }
    }
}
