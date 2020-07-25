using AutoMapper;
using IQTest.Api.Models;
using IQTest.Core.Entities;
using IQTest.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IQTest.Api.Controllers
{
    [ApiController]
    [Route("api/contactmessages")]
    public class ContactMessageController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContactMessageController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddNewMessage(ContactMessageDto contactMessageModel)
        {
            if (contactMessageModel == null)
            {
                return BadRequest();
            }

            ContactMessage contactMessage = _mapper.Map<ContactMessage>(contactMessageModel);

            _unitOfWork.ContactMessages.Add(contactMessage);
            _unitOfWork.Complete();

            return Ok();
        }
    }
}
