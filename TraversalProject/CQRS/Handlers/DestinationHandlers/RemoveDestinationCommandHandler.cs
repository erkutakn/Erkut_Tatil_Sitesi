using DataAccessLayer.Concrete;
using AkınTurizm.CQRS.Commands.DestinationCommands;

namespace AkınTurizm.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;

        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            var destID = _context.Destinations.Find(command.Id);
            _context.Destinations.Remove(destID);
            _context.SaveChanges();
        }
    }
}
