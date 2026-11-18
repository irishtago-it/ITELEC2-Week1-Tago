class ProjectTask
{
    public string Title { get; }
    public string AssignedTo { get; private set; }
    public DateTime DueDate { get; private set; }
    public bool IsDone { get; private set; }

    public ProjectTask(string title, string assignedTo, DateTime dueDate)
    {
        Title = title;
        AssignedTo = assignedTo;
        DueDate = dueDate;
    }

    // Rule: a task that is already done cannot be reassigned.
    public bool Reassign(string newMember)
    {
        if (IsDone || string.IsNullOrWhiteSpace(newMember)) return false;
        AssignedTo = newMember;
        return true;
    }

    public void MarkDone() => IsDone = true;
}
