﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using GraduateTraineeEnrollmentApi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace GraduateTraineeEnrollmentApi.Models
{
    public partial interface IAppDBContextProcedures
    {
        Task<List<TraineeEnrollmentReportResult>> TraineeEnrollmentReportAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
