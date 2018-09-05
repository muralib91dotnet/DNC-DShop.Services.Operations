using System;
using DShop.Common.Messages;
using Newtonsoft.Json;

namespace DShop.Services.Operations.Messages.Identity.Events
{
    [MessageNamespace("identity")]
    public class SignUpRejected : IRejectedEvent
    {
        public Guid UserId { get; }
        public string Reason { get; }
        public string Code { get; }

        [JsonConstructor]
        public SignUpRejected(Guid userId, string reason, string code)
        {
            UserId = userId;
            Reason = reason;
            Code = code;
        }
    }
}