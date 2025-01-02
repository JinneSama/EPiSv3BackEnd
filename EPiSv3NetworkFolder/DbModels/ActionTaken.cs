using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class ActionTaken
{
    public int Id { get; set; }

    public string? Action { get; set; }

    public DateTime? DateAdded { get; set; }
}
