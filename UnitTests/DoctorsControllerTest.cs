
//using Ophthalmologist;
//using Ophthalmologist.Controllers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UnitTests
//{

//    public class DoctorsControllerTest
//    {
//        private readonly DoctorController _controller;
//        //public DoctorsControllerTest()
//        //{
//        //    FakeContext context = new FakeContext();
//        //    _controller=new DoctorController(context);
//        //}
//        [Fact]
//        public void GetAll_ReturnsListOfDoctors()
//        {
//            //AAA

//            //Arrange
//            var controller = _controller;
//            var result = controller.Get();
//            //Act

//            //Assert

//            Assert.IsType<List<Doctor>>(result);
//        }

//        [Fact]
//        public void GetAll_ReturnsCount()
//        {
//            //AAA

//            //Arrange

//            //Act

//            var result = _controller.Get();
//            //Assert

//            Assert.Equal(1, result.Count());
//        }

//        [Fact]
//        public void GetById_ReturnsOk()
//        {
//            //AAA

//            //Arrange
//            var id = 1;
//            //Act
//            var controller =_controller;
//            var result = controller.Get(id);
//            //Assert
//            Assert.IsType<OkObjectResult>(result);
//        }

//        [Fact]
//        public void GetById_ReturnsNotFound()
//        {
//            //AAA

//            //Arrange
//            var id = 2;
//            //Act
//            var controller = _controller;
//            var result = controller.Get(id);
//            //Assert
//            Assert.IsType<NotFoundResult>(result);
//        }


//    }
//}
