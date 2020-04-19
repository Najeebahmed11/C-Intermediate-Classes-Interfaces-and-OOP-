using System.Collections.Generic;

namespace csharpintermediate
{

    public class Program

    {

        static void Main(string[] args)

        {

            //Creating new WorkFlow object and its empty list of steps.

            var workflow = new WorkFlow();



            //Adding new steps to workflow object created.

            workflow.AddStep(new Step("step 1"));

            workflow.AddStep(new Step("step 2"));

            workflow.AddStep(new Step("step 3"));



            //Running the workflow.

            var workflowengine = new WorkFlowEngine();

            workflowengine.Run(workflow);

        }

    }

}



//Workflow Engine_Controller



public class WorkFlowEngine

{

    //private readonly WorkFlow _workFlow;



    //public WorkFlowEngine( WorkFlow workFlow)

    //{

    //    this._workFlow = workFlow;

    //}



    public void Run(WorkFlow WorkFlow)

    {

        WorkFlow.ExcecuteWorkFLow();

    }

}



//Workflow Entityhvsxhsvj

public class WorkFlow

{

    public int IdWorkFlow { get; set; }

    public string Description { get; set; }

    private readonly IList<IStep> _steps;



    public WorkFlow()

    {

        _steps = new List<IStep>();

    }



    public void AddStep(IStep step)

    {

        _steps.Add(step);

    }



    public void ExcecuteWorkFLow()

    {

        foreach (var step in _steps)

        {

            step.Execute();

        }

    }

}



//Step(Activity) Entity

public class Step : IStep

{

    public int StepID { get; set; }

    public string StepDescription { get; set; }



    public Step(string stepDescription)

    {

        StepDescription = stepDescription;

    }



    public void Execute()

    {

        System.Console.WriteLine("Step excecuted - Description:{0} ", StepDescription);

    }

}

//Interface IStep definition

public interface IStep

{

    void Execute();

}




