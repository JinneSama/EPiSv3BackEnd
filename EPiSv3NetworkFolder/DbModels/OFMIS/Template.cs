using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Template
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? TemplateContent { get; set; }

    public string? Type { get; set; }

    public int? OfficeId { get; set; }
}
