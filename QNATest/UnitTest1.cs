using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QNA.Controllers;
using System.Web.Mvc;
using Moq;
using QNA.Data;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QNA.Models;


namespace QNATest
{
    [TestClass]
    public class HomeControllerTest
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly HomeController _homeController;

         //private readonly Mock<ILogger<HomeController>> _loggerMock = new Mock<ILogger<HomeController>>();


        public HomeControllerTest() {

           // _homeController = new HomeController((ILogger<HomeController>) _loggerMock);
        }

        [TestMethod]
        public void Index()
        {

            // Arrange
            HomeController controller = new HomeController((ILogger<HomeController>)_logger);

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsNotNull(result);
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
        public QuestionsControllerTest() { }

        private readonly ApplicationDbContext _context;

  

        public QuestionsControllerTest(ApplicationDbContext context)
        {
            _context = context;
        }

        [TestMethod]
        public async void Details()
        {
            // Arrange
            QuestionsController controller = new(_context);

            //var Result = await controller.Details(5);
            // ;
            // Act
            var result = await controller.Details(0);

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









    [TestClass]
    //Answer controller tests
    public class AnswersControllerTest
  {
       // private readonly Mock<ApplicationDbContext> _dbMock = new Mock<ApplicationDbContext>();

        public AnswersControllerTest()
        {

        }

        private readonly ApplicationDbContext _context;
        public AnswersControllerTest(ApplicationDbContext context)
        {

            _context = context;
        }
        [TestMethod]
      public void Create()
      {
            // Arrange
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            //optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);


            AnswersController controller = new AnswersController(_dbContext);
            //ViewData[0] = new SelectList(_context.Questions, 0, 0 );
            // Act
            ViewResult result = controller.Create() as ViewResult;

          // Assert
          Assert.IsNull(result);
      }


  }


    [TestClass]
    public class CategoriesControllerTest
  {
        public CategoriesControllerTest() { }


        private readonly ApplicationDbContext _context;



        public CategoriesControllerTest(ApplicationDbContext context)
        {

            _context = context;
        }


        [TestMethod]
      public void CategoryCreate()
      {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            // Arrange
            CategoriesController controller = new CategoriesController(_dbContext);

          // Act
          ViewResult result = controller.Create() as ViewResult;

            // Assert
            // Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            Assert.IsNull(result);
      }

  }


}




