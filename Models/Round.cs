using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace golfIQ.Models;

public class Round
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string CourseName { get; set; } = string.Empty;

    public DateTime Date { get; set; }

    public int Score { get; set; }
}