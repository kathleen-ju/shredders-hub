variable "aws_region" {
       description = "The AWS region to create things in." 
       default     = "ap-southeast-2" 
}

variable "key_name" { 
    description = " SSH keys to connect to ec2 instance" 
    default     =  "shredders-hub" 
}

variable "instance_type" { 
    description = "instance type for ec2" 
    default     =  "t2.micro" 
}

variable "security_group" { 
    description = "Name of security group" 
    default     = "shredders-hub-sg-2022" 
}

variable "tag_name" { 
    description = "Tag Name of for Ec2 instance" 
    default     = "my-ec2-instance" 
} 
variable "ami_id" { 
    description = "AMI for Ubuntu Ec2 instance" 
    default     = "ami-051a81c2bd3e755db" 
}

variable "ecr_name" {
    description = "name of ecr"
    default = "dotnet-user-api"
}
