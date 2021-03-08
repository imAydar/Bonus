using System;
using System.Threading.Tasks;
using Bonus.Core.Services.Interfaces;
using Bonus.Data.Models;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using Bonus.Data.DTOs;
using Bonus.Data.Models;
using Bonus.Data.Repositories;
//using TransactionDTO = Bonus.Data.Models.TransactionDTO;

namespace Bonus.Core.Services
{
    public class TransactionService: ITransactionService
    {
      // private readonly ICardService cardService;
        private readonly IMapper mapper;
        private readonly ITransactionRepository transactionRepository;
        private readonly ICardRepository cardRepository;
        public TransactionService(ICardService cardService, IMapper mapper, ITransactionRepository transactionRepository, ICardRepository cardRepository)
        {
           // this.cardService = cardService;
            this.mapper = mapper;
            this.transactionRepository = transactionRepository;
            this.cardRepository = cardRepository;
        }
        public async Task<Transaction> Commit(TransactionDTO transactionDto)
        {
            var transaction = mapper.Map<Transaction>(transactionDto);
            transaction.Id = 0;
            decimal bonusRate = cardRepository.GetBonusRate(transaction.CardId);
            transaction.Bonus = transactionDto.Summ * bonusRate;
            
            return transactionRepository.Commit(transaction);
        }
        
        /// <summary>
        /// Checks if the cheque is vaalid and commited
        /// </summary>
        /// <param name="transactionDto"></param>
        /// <returns></returns>
        private bool CheckReceipt(TransactionDTO transactionDto) =>
            true;
    }
}