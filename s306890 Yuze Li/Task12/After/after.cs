public class BrowseHistoryRecord
	{
		 public BrowseTime BrowseHistory { get; private set; }
		 public bool History { get; private set; }
	
		 public void HistoryRecord()
	 	{
		 	SwitchToHistory();
	 	}
	
	 	 public void CloseRecord()
		{
		 	SwitchToHistory();
		}
	
		 private void SwitchToHistory()
		{
		 	History = true;
		 	BrowseHistory = BrowseTime.Now;
		}
	}