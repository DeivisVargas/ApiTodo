using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Handlers.Contracts
{
    //restrição posso chmar sempre o Ihandler desde que <T> seja um ICommand 
    public interface IHandler<T> where T : ICommand
    {
        //restringe e sempre retorna um command Result
        ICommandResult Handle(T command);
    }
}