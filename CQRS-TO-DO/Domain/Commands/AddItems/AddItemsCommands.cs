using MediatR;

namespace CQRS_TO_DO.Domain
{
    public class AddItemsCommand : IRequest<Unit>
    {
        public AddItemsCommand(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; private set; }
        public double Value { get; private set; }
    }
}
