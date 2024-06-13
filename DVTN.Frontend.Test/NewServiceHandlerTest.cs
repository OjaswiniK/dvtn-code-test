using Moq;
using DVTN.Frontend.Web.Features.HomePage;
using MediatR;
using NUnit.Framework;

namespace DVTN.Frontend.Test
{
    public class Tests
    {
        private Mock<INewService> _newServiceMock;
        private Mock<IMediator> _mediatorMock;
        private HomePageRequestHandler _handler;


        [SetUp]
        public void Setup()
        {
            _newServiceMock = new Mock<INewService>();
            _mediatorMock = new Mock<IMediator> { CallBase = true };

            _newServiceMock.Setup(s => s.GetNewServiceMessage()).Returns("This message is from new Service");

            _handler = new HomePageRequestHandler(_mediatorMock.Object, _newServiceMock.Object);
        }

        [Test]
        public async Task GetNewServiceMessage()
        {
            //Arrange
            HomePageRequest request = new HomePageRequest();
            request.ImageUrl = "brand/logo.png";
            request.Textpanel = "Text Panel";
            request.LargeTextPanel = "This is a large text panel. You can put a lot of content here to provide detailed information about your website or any other topic you want to cover.";

            //Act
            HomePageViewModel result = await _handler.Handle(request, CancellationToken.None);

            //Assert
            Assert.That(result.TextPanelForServiceMessage.ToString(), Is.EqualTo("This message is from new Service"));
        }
    }
}