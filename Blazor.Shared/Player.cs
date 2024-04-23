using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAndSignalR.Shared;

public class Player(string connectionId, string name)
{
    public string ConnectionId { get; set; } = connectionId;
    public string Name { get; set; } = name; 
    
}
