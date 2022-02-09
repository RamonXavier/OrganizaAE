using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using OrganizaAE.Feactures.Mounth.Service;
using OrganizaAE.Feactures.Payment.Dto;
using OrganizaAE.Feactures.Social.Service;
using OrganizaAE.Feactures.User.Service;
using OrganizaAE.Infrastructure.Payment;

namespace OrganizaAE.Feactures.Payment.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IUserService _userService;
        private readonly ISocialService _socialService;
        private readonly IMounthService _mounthService;
        private readonly IMapper _mapper;

        public PaymentService(IPaymentRepository paymentRepository, IMapper mapper, IMounthService mounthService, ISocialService socialService, IUserService userService)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
            _mounthService = mounthService;
            _socialService = socialService;
            _userService = userService;
        }

        public async Task<IEnumerable<PaymentCompleteDto>> Get()
        {
            var listPayment = await _paymentRepository.GetAllAsyncWithSocialAndUserAndMounth();
            var listMapped = _mapper.Map<IEnumerable<PaymentCompleteDto>>(listPayment);
            return listMapped;
        }

        public async Task<PaymentCompleteDto> GetById(int idPayment)
        {
            var payment = await _paymentRepository.GetAllAsyncWithSocialAndUserAndMounthById(idPayment);
            var mapped = _mapper.Map<PaymentCompleteDto>(payment);
            return mapped;
        }

        public async Task Create(PaymentDto paymentDto)
        {
            var paymentMapped = _mapper.Map<Models.Payment.Payment>(paymentDto);
            await _paymentRepository.AddAndSaveAsync(paymentMapped);
        }

        public async Task Update(PaymentDto paymentDto)
        {
            var paymentMapped = _mapper.Map<Models.Payment.Payment>(paymentDto);
            await _paymentRepository.UpdateAsync(paymentMapped);
        }

        public async Task Delete(int idPayment)
        {
            var paymentActualy = await _paymentRepository.GetByIdAsync(idPayment);
            await _paymentRepository.DeleteAsync(paymentActualy);
            await _paymentRepository.Save();
        }
    }
}
