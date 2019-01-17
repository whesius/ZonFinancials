// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial class AccessControl : Allors.IObject , Cachable, Deletable, AccessControlledObject
	{
		private readonly IStrategy strategy;

		public AccessControl(Allors.IStrategy strategy) 
		{
			this.strategy = strategy;
		}

		public Allors.Meta.MetaAccessControl Meta
		{
			get
			{
				return Allors.Meta.MetaAccessControl.Instance;
			}
		}

		public long Id
		{
			get { return this.strategy.ObjectId; }
		}

		public IStrategy Strategy
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return this.strategy; }
        }

		public static AccessControl Instantiate (Allors.ISession allorsSession, string allorsObjectId)
		{
			return (AccessControl) allorsSession.Instantiate(allorsObjectId);		
		}

		public override bool Equals(object obj)
        {
            var typedObj = obj as IObject;
            return typedObj != null &&
                   typedObj.Strategy.ObjectId.Equals(this.Strategy.ObjectId) &&
                   typedObj.Strategy.Session.Database.Id.Equals(this.Strategy.Session.Database.Id);
        }

		public override int GetHashCode()
        {
            return this.Strategy.ObjectId.GetHashCode();
        }



		virtual public global::Allors.Extent<UserGroup> SubjectGroups
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.SubjectGroups.RelationType);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.SubjectGroups.RelationType, value);
			}
		}

		virtual public void AddSubjectGroup (UserGroup value)
		{
			Strategy.AddCompositeRole(Meta.SubjectGroups.RelationType, value);
		}

		virtual public void RemoveSubjectGroup (UserGroup value)
		{
			Strategy.RemoveCompositeRole(Meta.SubjectGroups.RelationType, value);
		}

		virtual public bool ExistSubjectGroups
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.SubjectGroups.RelationType);
			}
		}

		virtual public void RemoveSubjectGroups()
		{
			Strategy.RemoveCompositeRoles(Meta.SubjectGroups.RelationType);
		}


		virtual public global::Allors.Extent<User> Subjects
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.Subjects.RelationType);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.Subjects.RelationType, value);
			}
		}

		virtual public void AddSubject (User value)
		{
			Strategy.AddCompositeRole(Meta.Subjects.RelationType, value);
		}

		virtual public void RemoveSubject (User value)
		{
			Strategy.RemoveCompositeRole(Meta.Subjects.RelationType, value);
		}

		virtual public bool ExistSubjects
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.Subjects.RelationType);
			}
		}

		virtual public void RemoveSubjects()
		{
			Strategy.RemoveCompositeRoles(Meta.Subjects.RelationType);
		}


		virtual public Role Role
		{ 
			get
			{
				return (Role) Strategy.GetCompositeRole(Meta.Role.RelationType);
			}
			set
			{
				Strategy.SetCompositeRole(Meta.Role.RelationType, value);
			}
		}

		virtual public bool ExistRole
		{
			get
			{
				return Strategy.ExistCompositeRole(Meta.Role.RelationType);
			}
		}

		virtual public void RemoveRole()
		{
			Strategy.RemoveCompositeRole(Meta.Role.RelationType);
		}


		virtual public global::Allors.Extent<Permission> EffectivePermissions
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.EffectivePermissions.RelationType);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.EffectivePermissions.RelationType, value);
			}
		}

		virtual public void AddEffectivePermission (Permission value)
		{
			Strategy.AddCompositeRole(Meta.EffectivePermissions.RelationType, value);
		}

		virtual public void RemoveEffectivePermission (Permission value)
		{
			Strategy.RemoveCompositeRole(Meta.EffectivePermissions.RelationType, value);
		}

		virtual public bool ExistEffectivePermissions
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.EffectivePermissions.RelationType);
			}
		}

		virtual public void RemoveEffectivePermissions()
		{
			Strategy.RemoveCompositeRoles(Meta.EffectivePermissions.RelationType);
		}


		virtual public global::Allors.Extent<User> EffectiveUsers
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.EffectiveUsers.RelationType);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.EffectiveUsers.RelationType, value);
			}
		}

		virtual public void AddEffectiveUser (User value)
		{
			Strategy.AddCompositeRole(Meta.EffectiveUsers.RelationType, value);
		}

		virtual public void RemoveEffectiveUser (User value)
		{
			Strategy.RemoveCompositeRole(Meta.EffectiveUsers.RelationType, value);
		}

		virtual public bool ExistEffectiveUsers
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.EffectiveUsers.RelationType);
			}
		}

		virtual public void RemoveEffectiveUsers()
		{
			Strategy.RemoveCompositeRoles(Meta.EffectiveUsers.RelationType);
		}


		virtual public global::System.Guid CacheId 
		{
			get
			{
				return (global::System.Guid) Strategy.GetUnitRole(Meta.CacheId.RelationType);
			}
			set
			{
				Strategy.SetUnitRole(Meta.CacheId.RelationType, value);
			}
		}

		virtual public bool ExistCacheId{
			get
			{
				return Strategy.ExistUnitRole(Meta.CacheId.RelationType);
			}
		}

		virtual public void RemoveCacheId()
		{
			Strategy.RemoveUnitRole(Meta.CacheId.RelationType);
		}


		virtual public global::Allors.Extent<Permission> DeniedPermissions
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.DeniedPermissions.RelationType);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.DeniedPermissions.RelationType, value);
			}
		}

		virtual public void AddDeniedPermission (Permission value)
		{
			Strategy.AddCompositeRole(Meta.DeniedPermissions.RelationType, value);
		}

		virtual public void RemoveDeniedPermission (Permission value)
		{
			Strategy.RemoveCompositeRole(Meta.DeniedPermissions.RelationType, value);
		}

		virtual public bool ExistDeniedPermissions
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.DeniedPermissions.RelationType);
			}
		}

		virtual public void RemoveDeniedPermissions()
		{
			Strategy.RemoveCompositeRoles(Meta.DeniedPermissions.RelationType);
		}


		virtual public global::Allors.Extent<SecurityToken> SecurityTokens
		{ 
			get
			{
				return Strategy.GetCompositeRoles(Meta.SecurityTokens.RelationType);
			}
			set
			{
				Strategy.SetCompositeRoles(Meta.SecurityTokens.RelationType, value);
			}
		}

		virtual public void AddSecurityToken (SecurityToken value)
		{
			Strategy.AddCompositeRole(Meta.SecurityTokens.RelationType, value);
		}

		virtual public void RemoveSecurityToken (SecurityToken value)
		{
			Strategy.RemoveCompositeRole(Meta.SecurityTokens.RelationType, value);
		}

		virtual public bool ExistSecurityTokens
		{
			get
			{
				return Strategy.ExistCompositeRoles(Meta.SecurityTokens.RelationType);
			}
		}

		virtual public void RemoveSecurityTokens()
		{
			Strategy.RemoveCompositeRoles(Meta.SecurityTokens.RelationType);
		}



		virtual public Singleton SingletonWhereCreatorsAccessControl
		{ 
			get
			{
				return (Singleton) Strategy.GetCompositeAssociation(Meta.SingletonWhereCreatorsAccessControl.RelationType);
			}
		} 

		virtual public bool ExistSingletonWhereCreatorsAccessControl
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.SingletonWhereCreatorsAccessControl.RelationType);
			}
		}


		virtual public Singleton SingletonWhereGuestAccessControl
		{ 
			get
			{
				return (Singleton) Strategy.GetCompositeAssociation(Meta.SingletonWhereGuestAccessControl.RelationType);
			}
		} 

		virtual public bool ExistSingletonWhereGuestAccessControl
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.SingletonWhereGuestAccessControl.RelationType);
			}
		}


		virtual public Singleton SingletonWhereAdministratorsAccessControl
		{ 
			get
			{
				return (Singleton) Strategy.GetCompositeAssociation(Meta.SingletonWhereAdministratorsAccessControl.RelationType);
			}
		} 

		virtual public bool ExistSingletonWhereAdministratorsAccessControl
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.SingletonWhereAdministratorsAccessControl.RelationType);
			}
		}


		virtual public global::Allors.Extent<SecurityToken> SecurityTokensWhereAccessControl
		{ 
			get
			{
				return Strategy.GetCompositeAssociations(Meta.SecurityTokensWhereAccessControl.RelationType);
			}
		}

		virtual public bool ExistSecurityTokensWhereAccessControl
		{
			get
			{
				return Strategy.ExistCompositeAssociations(Meta.SecurityTokensWhereAccessControl.RelationType);
			}
		}


		virtual public SecurityTokenOwner SecurityTokenOwnerWhereOwnerAccessControl
		{ 
			get
			{
				return (SecurityTokenOwner) Strategy.GetCompositeAssociation(Meta.SecurityTokenOwnerWhereOwnerAccessControl.RelationType);
			}
		} 

		virtual public bool ExistSecurityTokenOwnerWhereOwnerAccessControl
		{
			get
			{
				return Strategy.ExistCompositeAssociation(Meta.SecurityTokenOwnerWhereOwnerAccessControl.RelationType);
			}
		}



		public ObjectOnBuild OnBuild()
		{ 
			var method = new AccessControlOnBuild(this);
            method.Execute();
            return method;
		}

		public ObjectOnBuild OnBuild(System.Action<ObjectOnBuild> action)
		{ 
			var method = new AccessControlOnBuild(this);
            action(method);
            method.Execute();
            return method;
		}

		public ObjectOnPostBuild OnPostBuild()
		{ 
			var method = new AccessControlOnPostBuild(this);
            method.Execute();
            return method;
		}

		public ObjectOnPostBuild OnPostBuild(System.Action<ObjectOnPostBuild> action)
		{ 
			var method = new AccessControlOnPostBuild(this);
            action(method);
            method.Execute();
            return method;
		}

		public ObjectOnPreDerive OnPreDerive()
		{ 
			var method = new AccessControlOnPreDerive(this);
            method.Execute();
            return method;
		}

		public ObjectOnPreDerive OnPreDerive(System.Action<ObjectOnPreDerive> action)
		{ 
			var method = new AccessControlOnPreDerive(this);
            action(method);
            method.Execute();
            return method;
		}

		public ObjectOnDerive OnDerive()
		{ 
			var method = new AccessControlOnDerive(this);
            method.Execute();
            return method;
		}

		public ObjectOnDerive OnDerive(System.Action<ObjectOnDerive> action)
		{ 
			var method = new AccessControlOnDerive(this);
            action(method);
            method.Execute();
            return method;
		}

		public ObjectOnPostDerive OnPostDerive()
		{ 
			var method = new AccessControlOnPostDerive(this);
            method.Execute();
            return method;
		}

		public ObjectOnPostDerive OnPostDerive(System.Action<ObjectOnPostDerive> action)
		{ 
			var method = new AccessControlOnPostDerive(this);
            action(method);
            method.Execute();
            return method;
		}

		public DeletableDelete Delete()
		{ 
			var method = new AccessControlDelete(this);
            method.Execute();
            return method;
		}

		public DeletableDelete Delete(System.Action<DeletableDelete> action)
		{ 
			var method = new AccessControlDelete(this);
            action(method);
            method.Execute();
            return method;
		}
	}

	public partial class AccessControlBuilder : Allors.ObjectBuilder<AccessControl> , CachableBuilder, DeletableBuilder, AccessControlledObjectBuilder, global::System.IDisposable
	{		
		public AccessControlBuilder(Allors.ISession session) : base(session)
	    {
	    }

		protected override void OnBuild(AccessControl instance)
		{
			

			if(this.CacheId.HasValue)
			{
				instance.CacheId = this.CacheId.Value;
			}			
		
		
			if(this.SubjectGroups!=null)
			{
				instance.SubjectGroups = this.SubjectGroups.ToArray();
			}
		
			if(this.Subjects!=null)
			{
				instance.Subjects = this.Subjects.ToArray();
			}
		

			instance.Role = this.Role;

						
			if(this.DeniedPermissions!=null)
			{
				instance.DeniedPermissions = this.DeniedPermissions.ToArray();
			}
		
			if(this.SecurityTokens!=null)
			{
				instance.SecurityTokens = this.SecurityTokens.ToArray();
			}
		
		}


				public global::System.Collections.Generic.List<UserGroup> SubjectGroups {get; set;}	

				/// <exclude/>
				public AccessControlBuilder WithSubjectGroup(UserGroup value)
		        {
					if(this.SubjectGroups == null)
					{
						this.SubjectGroups = new global::System.Collections.Generic.List<UserGroup>(); 
					}
		            this.SubjectGroups.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<User> Subjects {get; set;}	

				/// <exclude/>
				public AccessControlBuilder WithSubject(User value)
		        {
					if(this.Subjects == null)
					{
						this.Subjects = new global::System.Collections.Generic.List<User>(); 
					}
		            this.Subjects.Add(value);
		            return this;
		        }		

				
				public Role Role {get; set;}

				/// <exclude/>
				public AccessControlBuilder WithRole(Role value)
		        {
		            if(this.Role!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Role = value;
		            return this;
		        }		

				
				public global::System.Guid? CacheId {get; set;}

				/// <exclude/>
				public AccessControlBuilder WithCacheId(global::System.Guid? value)
		        {
				    if(this.CacheId!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.CacheId = value;
		            return this;
		        }	

				public global::System.Collections.Generic.List<Permission> DeniedPermissions {get; set;}	

				/// <exclude/>
				public AccessControlBuilder WithDeniedPermission(Permission value)
		        {
					if(this.DeniedPermissions == null)
					{
						this.DeniedPermissions = new global::System.Collections.Generic.List<Permission>(); 
					}
		            this.DeniedPermissions.Add(value);
		            return this;
		        }		

				
				public global::System.Collections.Generic.List<SecurityToken> SecurityTokens {get; set;}	

				/// <exclude/>
				public AccessControlBuilder WithSecurityToken(SecurityToken value)
		        {
					if(this.SecurityTokens == null)
					{
						this.SecurityTokens = new global::System.Collections.Generic.List<SecurityToken>(); 
					}
		            this.SecurityTokens.Add(value);
		            return this;
		        }		

				

	}

	public partial class AccessControls : global::Allors.ObjectsBase<AccessControl>
	{
		public AccessControls(Allors.ISession session) : base(session)
		{
		}

		public Allors.Meta.MetaAccessControl Meta
		{
			get
			{
				return Allors.Meta.MetaAccessControl.Instance;
			}
		}

		public override Allors.Meta.Composite ObjectType
		{
			get
			{
				return Meta.ObjectType;
			}
		}
	}

}