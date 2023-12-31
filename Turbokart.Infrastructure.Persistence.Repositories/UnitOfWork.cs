﻿using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Turbokart.Infrastructure.Persistence.Interfaces;

namespace Turbokart.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private DbContext dbContext;
        private IBookingRepository bookingRepository;
        private ICustomerRepository customerRepository;

        public UnitOfWork(
            DbContext dbContext, 
            IBookingRepository bookingRepository, 
            ICustomerRepository customerRepository)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.bookingRepository = bookingRepository ?? throw new ArgumentNullException(nameof(bookingRepository));
            this.customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        }

        public IBookingRepository BookingRepository => bookingRepository;

        public ICustomerRepository CustomerRepository => customerRepository;
 
        public void Commit()
        {
            try
            {
                dbContext.SaveChanges();
            }
            catch(Exception e)
            {
                throw new UnitOfWorkException("Unable to commit transaction.", e);
            }
        }

        public void Dispose()
        {
            try
            {
                dbContext.Dispose();
            }
            catch(Exception e)
            {
                throw new UnitOfWorkException("Unable to dispose", e);
            }
            finally
            {
                dbContext = null;
            }
        }

        public void RollBack()
        {
            
        }
    }
}
