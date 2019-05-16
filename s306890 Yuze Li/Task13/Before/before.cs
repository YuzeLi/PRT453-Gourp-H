public class Admin
 {
	 public IWebsiteAdmin WebsiteAdmin { get; set; }
	
	 public Admin(IWebsiteAdmin websiteAdmin)
	 {
		 WebsiteAdmin = websiteAdmin;
	 }
	
	 public bool HasAccess(User user, Permission permission, IEnumerable<Permission> exemptions)
	 {
		bool hasPermission = false;
	
		if (user != null)
		{
			if (permission != null)
			{
				if (exemptions.Count() == 0)
				{
					if (WebsiteAdmin.CheckPermission(user, permission) || exemptions.Contains(permission))
					{
						hasPermission = true;
					}
				}
			}
		}
	
		return hasPermission;
	 }
 }