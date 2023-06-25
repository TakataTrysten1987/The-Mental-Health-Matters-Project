# Set up libraries
library(dplyr)
library(tidyverse)
library(stringr)

# Read in data sources
mental_health_df <- read.csv("data/mental_health.csv")
datasets_df <- read.csv("data/mental_health_datasets.csv")

# Function to get list of resourses given search criteria
get_resources <- function(ment_health_data, dataset, criteria){

# Subset dataset based on criteria
  subset_data <- ment_health_data %>%
    filter(str_detect(topic, criteria))

# Get list of resources from dataset
  resources_list <- datasets_df %>%
    filter(str_detect(dataset, criteria)) %>%
    select(resource)

# Return list of resources
  resources_list

}

# Function to print resources given list
print_resources <- function(list){
  for (resource in list){
    print(resource)
  }
}

# Function to make recommendations
make_recommendations <- function(ment_health_data, dataset, criteria){

# Get list of resources
  resources_list <- get_resources(ment_health_data, dataset, criteria)

# Print resources  
  print_resources(resources_list)
  
}

# Main Function
promote_wellness_resilience <- function(ment_health_data, dataset){

# Print welcome message
  print('Welcome to the mental health support and resources program!')
  
# Make recommendations
  make_recommendations(ment_health_data, dataset, 'mental health')
  make_recommendations(ment_health_data, dataset, 'wellness')
  make_recommendations(ment_health_data, dataset, 'resilience')
  
# Print goodbye message
  print('Thank you for using the mental health support and resources program. Have a good day!')
  
}

# Call main function
promote_wellness_resilience(mental_health_df, datasets_df)