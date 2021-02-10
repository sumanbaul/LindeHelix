using Glass.Mapper.Sc.Web.Mvc;
using Linde.Feature.BasicContent.Models;
using Linde.Feature.BasicContent.ViewModels;
using Sitecore.Data.Fields;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using System;
using System.Web.Mvc;

namespace Linde.Feature.BasicContent.Controllers
{
    public class HeaderController : Controller
    {
        // GET: Header
        public ActionResult GetHeader()
        {
            //var datasourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            //var dataSource = Sitecore.Context.Database.GetItem(datasourceId);
            //var x = dataSource.Fields["Image"].Value;

            //HeaderBuilder headerBuilder = new HeaderBuilder();
            //headerBuilder.Title = dataSource.Fields["Title"].ToString();
            //headerBuilder.Image = dataSource.Fields["Image"].Value;
            //headerBuilder.Body = dataSource.Fields["Body"].ToString();

            //var _headerViewModel = new HeaderViewModel()
            //{
            //    HasdataSource = datasourceId != null,
            //    _headerBuilder =  headerBuilder
            //};

            //var sourceItem = RenderingContext.Current.Rendering.Item;
            #region Mapping Fields
            var pageModel = new HeaderViewModel();

            try
            {
                //pageModel.HasdataSource = sourceItem != null;
                //pageModel.Title = sourceItem.Fields["Title"].Value.ToString();
                //pageModel.Body = sourceItem.Fields["Body"].Value.ToString();
                

                //DateField dateField = sourceItem.Fields["Date"];
                //if (dateField != null)
                //{
                //    pageModel.Date = dateField.DateTime;
                //}

                //ImageField imageField = sourceItem.Fields["Image"];
                //if (imageField != null)
                //{
                    //pageModel._headerBuilder.Image = new Glass.Mapper.Sc.Fields.Image()
                    //{
                    //    Src = Sitecore.Resources.Media.MediaManager.GetMediaUrl(imageField.MediaItem)
                    //};
                //}




                var mvcContext = new MvcContext();
                //var source = mvcContext.GetContextItem<HeaderBuilder>();
                var source = mvcContext.GetDataSourceItem<HeaderViewModel>();

                var logger = log4net.LogManager.GetLogger("Sitecore.Diagnostics.Custom");
                logger.Info("Sample Logging description info");

                return View(source);

            }
            catch(Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "HeaderController", "GetHeader"));
            }
            

            #endregion

        }
    }
}