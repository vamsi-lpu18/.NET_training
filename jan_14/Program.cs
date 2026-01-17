enum RiskLevel
{
    Low,Medium,High,Critical
}

enum SDLCStage
{
    Backlog,
Requirement,
Design,
Development,
CodeReview,
Testing,
UAT,
Deployment,
Maintenance

}

sealed class Requirement
{
    public int id{get;}
    public string Title{get;}
    public RiskLevel Risk{get;}

    public Requirement(int Id,string title,RiskLevel risk)
    {
        id=Id;
        Title=title;
        Risk=RiskLevel.risk;
    }
}
sealed class WorkItem
{
    public int id{get;}
    public string Name{get;}
    public SDLCStage Stage;
    public HashSet<int>DependencyIds{get;}

    public WorkItem(string name,int Id,SDLCStage sdlc)
    {
        Name=name;
        id=Id;
        Stage=SDLCStage.sdlc;
        
    }
}
sealed class BuildSnapShot
{
    public string Version{get;}
    public DateTime Timestamp{get;}
    public BuildSnapShot(string v,DateTime d)
    {
        Version=v;
        Timestamp=d;
    }
}
sealed class AuditLog
{
    public DateTime time{get;}
    public string Action{get;}

    public AuditLog(string action)
    {
        Action=action;
        time=DateTime.Now;
    }
}
public class QuialityMetric
{
    public string Name{get;}
    public  string Score{get;}
}
class EnterpriseSDLCEngine
{
    private List<Requirement> requirements;
    private Dictionary<int,WorkItem>_workItemRegistry;
    private SortedDictionary<SDLCStage,List<WorkItem>>_stageBoard;
    private Queue<WorkItem>_executionQueue;
    private Stack<BuildSnapShot> _rollbackStack;
    private HashSet<string>_uniqueTestSuites;
    private LinkedList<AuditLog>_auditLedger;
    private SortedSet<double,QuialityMetric>_releaseScoreboard;
    private int _requirementCounter;
    private int _workItemCounter;
    public EnterpriseSDLCEngine()
    {
        requirements=new List<Requirement>();
        _workItemRegistry=new Dictionary<int, WorkItem>();
        _stageBoard =new SortedDictionary<SDLCStage, List<WorkItem>>();
        foreach(var ele in _stageBoard)
        {
            ele=new KeyValuePair<SDLCStage, List<WorkItem>>();
        }
        _executionQueue =new Queue<WorkItem>();
        _rollbackStack =new Stack<BuildSnapShot>();
        _uniqueTestSuites =new HashSet<string>();
        _auditLedger =new LinkedList<AuditLog>();
        _releaseScoreboard =new SortedSet<T>();

    }
    public void AddRequirement(string title,RiskLevel risk)
    {
        Requirement req=new Requirement(_requirementCounter++, title, risk);
        requirements.Add(req);
        AuditLog log=new AuditLog("Created");
        _auditLedger.Append(log);
    }
    public WorkItem CreateWorkItem(string name,SDLCStage stage)
    {
        WorkItem item=new WorkItem(name,_workItemCounter++,stage);
        _workItemRegistry.Add(_workItemCounter-1,item);
    }
}