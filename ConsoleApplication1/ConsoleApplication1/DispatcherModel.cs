namespace ConsoleApplication1
{
    public class DispatcherModel
    {
        public DispatcherModel()
        {
            this.CurrentState = new StateModel();
            this.Transition = new TransitionModel();
            this.NextState = new StateModel();
        }

        public StateModel CurrentState { get; set; }
        public TransitionModel Transition { get; set; }
        public StateModel NextState { get; set; }
    }
}