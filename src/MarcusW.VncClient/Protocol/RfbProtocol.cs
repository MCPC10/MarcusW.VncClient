using System;
using System.Collections.Generic;
using MarcusW.VncClient.Protocol.Encodings;
using MarcusW.VncClient.Protocol.Services.Communication;

namespace MarcusW.VncClient.Protocol
{
    /// <summary>
    /// Default implementation of the RFB protocol.
    /// </summary>
    public class RfbProtocol : IRfbProtocolImplementation
    {
        /// <inheritdoc />
        public IReadOnlyCollection<IEncoding> SupportedEncodings { get; }

        internal RfbProtocol(IReadOnlyCollection<IEncoding> supportedEncodings)
        {
            SupportedEncodings = supportedEncodings;
        }

        /// <inheritdoc />
        public IRfbMessageReceiver CreateMessageReceiver(RfbConnection connection)
            => new RfbMessageReceiver(connection);

        /// <inheritdoc />
        public IRfbMessageSender CreateMessageSender(RfbConnection connection) => new RfbMessageSender();
    }
}