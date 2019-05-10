 public class BrowseHistoryRecord
	 {
		 public BrowseTime BrowseHistory { get; private set; }
		 public bool History { get; private set; }
	
		 public void HistoryRecord()
		 {
			 History = true;
			 BrowseHistory = BrowseTime.Now;
		 }
	
		 public void CloseRecord()
		 {
			 History = true;
			 BrowseHistory = BrowseTime.Now;
		 }
	 }