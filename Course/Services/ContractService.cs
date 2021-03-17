using System;
using System.Collections.Generic;
using Course.Entities;

namespace Course.Services {
    class ContractService {
        private double parcel;
        private double interest;
        private Installment quota;
        List<Installment> installments = new List<Installment>();
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months) {            
            parcel = contract.TotalValue / months;

            for (int i = 1; i <= months; i++) {
                interest = _onlinePaymentService.Interest(parcel, i);
                quota = new Installment(contract.Date.AddMonths(i), _onlinePaymentService.PaymentFee(interest));

                installments.Add(quota);
            }
        }

        public void ImpressInstallments() {
            foreach (Installment installment in installments) {
                Console.WriteLine(installment);
            }
        }

    }
}
