namespace Blazor.Data;

public class RequestService
{
    private readonly Dictionary<string,int> _responses = new Dictionary<string, int>();

    public void Register( string machineName )
    {
        if(!_responses.ContainsKey(machineName))
        {
            _responses.Add(machineName, 0);
        }

        _responses[machineName]++;
    }

    public RequestData GetData()
    {
        var data = new RequestData();

        foreach( var key in _responses.Keys )
        {
            data.TotalRequests += _responses[key];
        }

        foreach( var key in _responses.Keys )
        {
            data.Entries.Add( new RequestEntry
            {
                MachineName = key,
                Occurences = _responses[key],
                Percentage = (decimal)_responses[key] / (decimal)data.TotalRequests * 100.0M
            });
        }

        return data;
    }
}