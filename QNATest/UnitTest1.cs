using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QNA.Controllers;
using System.Web.Mvc;
using Moq;
using QNA.Data;
using System;
using System.Threading.Tasks;

namespace QNATest
{
    [TestClass]
    public class HomeControllerTest
    {
        private ILogger<HomeController> _logger;
        private readonly HomeController _homeController;

         private Mock<ILogger<HomeController>> _loggerMock = new Mock<ILogger<HomeController>>();


        public HomeControllerTest() {

           // _homeController = new HomeController((ILogger<HomeController>) _loggerMock);
        }

        [TestMethod]
        public void Index()
        {

            // Arrange
            HomeController controller = new HomeController((ILogger<HomeController>)_logger);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Privacy()
        {
            // Arrange
            HomeController controller = new HomeController((ILogger<HomeController>)_logger); ;

            // Act
            ViewResult result = controller.Privacy() as ViewResult;

            // Assert
            Assert.IsNull(result);
            //Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }


    }


    [TestClass]
    //Question controller tests
    public class QuestionsControllerTest
    {

        private ApplicationDbContext _context;
        public QuestionsControllerTest(ApplicationDbContext context)
        {
            _context = context;
        }

        [TestMethod]
        public async void Details()
        {
            // Arrange
            QuestionsController controller = new QuestionsController(_context);

            // var Result = await controller.Details(5)
            // ;
            // Act
            ViewResult result = await controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            //Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

    }
        /*[DataRow("id", 1)]*/
       

       /* private ViewResult Details()
        {
            throw new NotImplementedException();
        }*/
    


    




    /*

  //Answer controller tests
  public class AnswersControllerTest
  {

      [TestMethod]
      public void Create()
      {
          // Arrange
          AnswersController controller = new AnswersController();

          // Act
          ViewResult result = controller.Create() as ViewResult;

          // Assert
          Assert.IsNotNull(result);
      }


  }
  public class CategoriesControllerTest
  {



      [TestMethod]
      public void Create()
      {
          // Arrange
          CategoriesController controller = new CategoriesController();

          // Act
          ViewResult result = controller.Create() as ViewResult;

          // Assert
          Assert.AreEqual("Your application description page.", result.ViewBag.Message);
      }

  }*/


}




