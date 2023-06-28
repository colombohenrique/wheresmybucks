namespace Application.Services
{
    public class ResultModel<T>
    {
        public T? Data { get; }
        public bool Success { get; private set; }
        public List<string> Messages { get; } = new();
        public ResultModel(T data, List<string> messages)
        {
            Data = data;
            Messages = messages;
        }

        public ResultModel(T? data)
        {
            Success = true;
            Data = data;
        }
        public ResultModel(bool sucess, List<string> messages)
        {
            Success = sucess;
            Messages = messages;
        }

        public ResultModel(bool sucess, string message)
        {
            Success = sucess;
            Messages.Add(message);
        }

        public bool HasErrors()
        {
            return Messages.Any() && !Success;
        }
        public bool HasMessages()
        {
            return Messages.Any() && Success;
        }

        public void AddError(string error)
        {
            Success = false;
            Messages.Add(error);
        }
        public void AddErrors(List<string> errors)
        {
            Success = false;
            Messages.AddRange(errors);
        }
    }
}
