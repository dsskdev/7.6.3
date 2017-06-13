using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "9d852b97afe10ac6")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1067 with alias "umbracoProperties"
	/// <summary>Umbraco Properties</summary>
	public partial interface IUmbracoProperties : IPublishedContent
	{
		/// <summary>Umbraco Internal Redirect Id</summary>
		IPublishedContent UmbracoInternalRedirectId { get; }

		/// <summary>Umbraco Navi Hide</summary>
		bool UmbracoNaviHide { get; }

		/// <summary>Umbraco Redirect</summary>
		IPublishedContent UmbracoRedirect { get; }

		/// <summary>Umbraco Sitemap Hide</summary>
		bool UmbracoSitemapHide { get; }

		/// <summary>Umbraco Url Alias</summary>
		string UmbracoUrlAlias { get; }

		/// <summary>Umbraco Url Name</summary>
		string UmbracoUrlName { get; }
	}

	/// <summary>Umbraco Properties</summary>
	[PublishedContentModel("umbracoProperties")]
	public partial class UmbracoProperties : PublishedContentModel, IUmbracoProperties
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbracoProperties";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbracoProperties(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbracoProperties, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public IPublishedContent UmbracoInternalRedirectId
		{
			get { return GetUmbracoInternalRedirectId(this); }
		}

		/// <summary>Static getter for Umbraco Internal Redirect Id</summary>
		public static IPublishedContent GetUmbracoInternalRedirectId(IUmbracoProperties that) { return that.GetPropertyValue<IPublishedContent>("umbracoInternalRedirectId"); }

		///<summary>
		/// Umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return GetUmbracoNaviHide(this); }
		}

		/// <summary>Static getter for Umbraco Navi Hide</summary>
		public static bool GetUmbracoNaviHide(IUmbracoProperties that) { return that.GetPropertyValue<bool>("umbracoNaviHide"); }

		///<summary>
		/// Umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect
		{
			get { return GetUmbracoRedirect(this); }
		}

		/// <summary>Static getter for Umbraco Redirect</summary>
		public static IPublishedContent GetUmbracoRedirect(IUmbracoProperties that) { return that.GetPropertyValue<IPublishedContent>("umbracoRedirect"); }

		///<summary>
		/// Umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return GetUmbracoSitemapHide(this); }
		}

		/// <summary>Static getter for Umbraco Sitemap Hide</summary>
		public static bool GetUmbracoSitemapHide(IUmbracoProperties that) { return that.GetPropertyValue<bool>("umbracoSitemapHide"); }

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return GetUmbracoUrlAlias(this); }
		}

		/// <summary>Static getter for Umbraco Url Alias</summary>
		public static string GetUmbracoUrlAlias(IUmbracoProperties that) { return that.GetPropertyValue<string>("umbracoUrlAlias"); }

		///<summary>
		/// Umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return GetUmbracoUrlName(this); }
		}

		/// <summary>Static getter for Umbraco Url Name</summary>
		public static string GetUmbracoUrlName(IUmbracoProperties that) { return that.GetPropertyValue<string>("umbracoUrlName"); }
	}

	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Branch</summary>
	[PublishedContentModel("branch")]
	public partial class Branch : PublishedContentModel, IDefaultContent, IUmbracoProperties
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "branch";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Branch(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Branch, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Page Image: Main image for page
		///</summary>
		[ImplementPropertyType("pageImage")]
		public IPublishedContent PageImage
		{
			get { return Umbraco.Web.PublishedContentModels.DefaultContent.GetPageImage(this); }
		}

		///<summary>
		/// Page Links: Add links to external and internal content on page
		///</summary>
		[ImplementPropertyType("pageLinks")]
		public Umbraco.Web.Models.RelatedLinks PageLinks
		{
			get { return Umbraco.Web.PublishedContentModels.DefaultContent.GetPageLinks(this); }
		}

		///<summary>
		/// Page RTE: Rich Text Editor for main content of page
		///</summary>
		[ImplementPropertyType("pageRTE")]
		public IHtmlString PageRte
		{
			get { return Umbraco.Web.PublishedContentModels.DefaultContent.GetPageRte(this); }
		}

		///<summary>
		/// Page Title: Title for page
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.DefaultContent.GetPageTitle(this); }
		}

		///<summary>
		/// Umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public IPublishedContent UmbracoInternalRedirectId
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// Umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// Umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// Umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>Page</summary>
	[PublishedContentModel("page")]
	public partial class Page : PublishedContentModel, IDefaultContent, IUmbracoProperties
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "page";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Page(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Page, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Page Image: Main image for page
		///</summary>
		[ImplementPropertyType("pageImage")]
		public IPublishedContent PageImage
		{
			get { return Umbraco.Web.PublishedContentModels.DefaultContent.GetPageImage(this); }
		}

		///<summary>
		/// Page Links: Add links to external and internal content on page
		///</summary>
		[ImplementPropertyType("pageLinks")]
		public Umbraco.Web.Models.RelatedLinks PageLinks
		{
			get { return Umbraco.Web.PublishedContentModels.DefaultContent.GetPageLinks(this); }
		}

		///<summary>
		/// Page RTE: Rich Text Editor for main content of page
		///</summary>
		[ImplementPropertyType("pageRTE")]
		public IHtmlString PageRte
		{
			get { return Umbraco.Web.PublishedContentModels.DefaultContent.GetPageRte(this); }
		}

		///<summary>
		/// Page Title: Title for page
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.DefaultContent.GetPageTitle(this); }
		}

		///<summary>
		/// Umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public IPublishedContent UmbracoInternalRedirectId
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// Umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// Umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// Umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlName(this); }
		}
	}

	// Mixin content Type 1077 with alias "defaultContent"
	/// <summary>Default Content</summary>
	public partial interface IDefaultContent : IPublishedContent
	{
		/// <summary>Page Image</summary>
		IPublishedContent PageImage { get; }

		/// <summary>Page Links</summary>
		Umbraco.Web.Models.RelatedLinks PageLinks { get; }

		/// <summary>Page RTE</summary>
		IHtmlString PageRte { get; }

		/// <summary>Page Title</summary>
		string PageTitle { get; }
	}

	/// <summary>Default Content</summary>
	[PublishedContentModel("defaultContent")]
	public partial class DefaultContent : PublishedContentModel, IDefaultContent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "defaultContent";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public DefaultContent(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DefaultContent, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Page Image: Main image for page
		///</summary>
		[ImplementPropertyType("pageImage")]
		public IPublishedContent PageImage
		{
			get { return GetPageImage(this); }
		}

		/// <summary>Static getter for Page Image</summary>
		public static IPublishedContent GetPageImage(IDefaultContent that) { return that.GetPropertyValue<IPublishedContent>("pageImage"); }

		///<summary>
		/// Page Links: Add links to external and internal content on page
		///</summary>
		[ImplementPropertyType("pageLinks")]
		public Umbraco.Web.Models.RelatedLinks PageLinks
		{
			get { return GetPageLinks(this); }
		}

		/// <summary>Static getter for Page Links</summary>
		public static Umbraco.Web.Models.RelatedLinks GetPageLinks(IDefaultContent that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("pageLinks"); }

		///<summary>
		/// Page RTE: Rich Text Editor for main content of page
		///</summary>
		[ImplementPropertyType("pageRTE")]
		public IHtmlString PageRte
		{
			get { return GetPageRte(this); }
		}

		/// <summary>Static getter for Page RTE</summary>
		public static IHtmlString GetPageRte(IDefaultContent that) { return that.GetPropertyValue<IHtmlString>("pageRTE"); }

		///<summary>
		/// Page Title: Title for page
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return GetPageTitle(this); }
		}

		/// <summary>Static getter for Page Title</summary>
		public static string GetPageTitle(IDefaultContent that) { return that.GetPropertyValue<string>("pageTitle"); }
	}

	/// <summary>Search</summary>
	[PublishedContentModel("search")]
	public partial class Search : PublishedContentModel, IUmbracoProperties
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "search";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Search(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Search, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Search Content
		///</summary>
		[ImplementPropertyType("searchContent")]
		public string SearchContent
		{
			get { return this.GetPropertyValue<string>("searchContent"); }
		}

		///<summary>
		/// Umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public IPublishedContent UmbracoInternalRedirectId
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// Umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// Umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// Umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>Partner</summary>
	[PublishedContentModel("partner")]
	public partial class Partner : PublishedContentModel, IUmbracoProperties
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "partner";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Partner(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Partner, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Partner Image: Image of partner
		///</summary>
		[ImplementPropertyType("partnerImage")]
		public IPublishedContent PartnerImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("partnerImage"); }
		}

		///<summary>
		/// Partner Name: Name of partner
		///</summary>
		[ImplementPropertyType("partnerName")]
		public string PartnerName
		{
			get { return this.GetPropertyValue<string>("partnerName"); }
		}

		///<summary>
		/// Umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public IPublishedContent UmbracoInternalRedirectId
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// Umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// Umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// Umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>Department</summary>
	[PublishedContentModel("department")]
	public partial class Department : PublishedContentModel, IUmbracoProperties
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "department";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Department(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Department, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Department Image
		///</summary>
		[ImplementPropertyType("departmentImage")]
		public IPublishedContent DepartmentImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("departmentImage"); }
		}

		///<summary>
		/// Department Location: Location of department
		///</summary>
		[ImplementPropertyType("departmentLocation")]
		public string DepartmentLocation
		{
			get { return this.GetPropertyValue<string>("departmentLocation"); }
		}

		///<summary>
		/// Department Name: Name of department
		///</summary>
		[ImplementPropertyType("departmentName")]
		public string DepartmentName
		{
			get { return this.GetPropertyValue<string>("departmentName"); }
		}

		///<summary>
		/// Umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public IPublishedContent UmbracoInternalRedirectId
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// Umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// Umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// Umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>People</summary>
	[PublishedContentModel("people")]
	public partial class People : PublishedContentModel, IUmbracoProperties
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "people";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public People(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<People, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// People Image: Image of person
		///</summary>
		[ImplementPropertyType("peopleImage")]
		public IPublishedContent PeopleImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("peopleImage"); }
		}

		///<summary>
		/// People Name: Name of person
		///</summary>
		[ImplementPropertyType("peopleName")]
		public string PeopleName
		{
			get { return this.GetPropertyValue<string>("peopleName"); }
		}

		///<summary>
		/// People Role: Role of person
		///</summary>
		[ImplementPropertyType("peopleRole")]
		public string PeopleRole
		{
			get { return this.GetPropertyValue<string>("peopleRole"); }
		}

		///<summary>
		/// Umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public IPublishedContent UmbracoInternalRedirectId
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// Umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// Umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// Umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>News</summary>
	[PublishedContentModel("news")]
	public partial class News : PublishedContentModel, IUmbracoProperties
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "news";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public News(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<News, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public IPublishedContent UmbracoInternalRedirectId
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// Umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// Umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// Umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>Event</summary>
	[PublishedContentModel("event")]
	public partial class Event : PublishedContentModel, IUmbracoProperties
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "event";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Event(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Event, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Event Image: Image of event
		///</summary>
		[ImplementPropertyType("eventImage")]
		public IPublishedContent EventImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("eventImage"); }
		}

		///<summary>
		/// Event Location: Location of event
		///</summary>
		[ImplementPropertyType("eventLocation")]
		public string EventLocation
		{
			get { return this.GetPropertyValue<string>("eventLocation"); }
		}

		///<summary>
		/// Event Name: Name of Event
		///</summary>
		[ImplementPropertyType("eventName")]
		public string EventName
		{
			get { return this.GetPropertyValue<string>("eventName"); }
		}

		///<summary>
		/// Umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public IPublishedContent UmbracoInternalRedirectId
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// Umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// Umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// Umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return Umbraco.Web.PublishedContentModels.UmbracoProperties.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
