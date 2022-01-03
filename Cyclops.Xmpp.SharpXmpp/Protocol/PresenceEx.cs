using Cyclops.Xmpp.Protocol;
using SharpXMPP.XMPP.Client.Elements;

namespace Cyclops.Xmpp.SharpXmpp.Protocol;

internal static class PresenceEx
{
    private class Presence : IPresence
    {
        internal readonly XMPPPresence Original;
        public Presence(XMPPPresence original)
        {
            Original = original;
        }

        public Jid? From => Original.From.Map();
        public Jid? To => Original.To.Map();
        public string? Status => throw new NotImplementedException();
        public string? Show => throw new NotImplementedException();
        public IError? Error => throw new NotImplementedException();
    }

    public static IPresence Wrap(this XMPPPresence presence) => new Presence(presence);
    public static XMPPPresence Unwrap(this IPresence presence) => ((Presence)presence).Original;
}
