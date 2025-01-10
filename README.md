# ProductProposalManager

**ProductProposalManager** is an internal web application designed for companies to facilitate the submission and management of product improvement proposals by employees. Developed using Microsoft's technology stack, it ensures a streamlined process for enhancing product quality through employee feedback.

## Table of Contents

1. [Introduction](#introduction)
2. [Features](#features)
3. [Technologies Used](#technologies-used)
4. [Installation](#installation)

## Introduction

In a bid to continuously improve products, companies often rely on feedback and suggestions from their employees. **ProductProposalManager** serves this purpose by allowing employees to submit proposals for product enhancements. Each employee can view their submissions and track their statuses, ensuring transparency and encouraging active participation in the product development process.

## Features

- **User Authentication**: Secure login system for employees and administrators.
- **Proposal Submission**: Employees can submit new proposals linked to specific products.
- **Status Tracking**: Each proposal is assigned one of the following statuses:
  - **NA RAZMATRANJU** (Under Review)
  - **NA ČEKANJU** (Pending)
  - **PRIHVAĆENO** (Accepted)
  - **ODBIJENO** (Rejected)
- **Personalized Dashboard**: Employees can view their submitted proposals along with the current status.
- **Administrative Control**: Administrators have the authority to update the status of proposals.

## Technologies Used

- **Backend**: .NET Core
- **Frontend**: Blazor
- **Database**: Microsoft SQL Server (MS SQL)
- **Language**: C#

## Installation

To set up the **ProductProposalManager** application locally, follow these steps:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/MarinoLucicRaguz/ProductProposalManager.git
