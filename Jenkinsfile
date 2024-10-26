pipeline {
    agent any

    stages {
        stage('Checkout code') {
            steps {
                // Checkout the code from the public repository
                git url: 'https://github.com/enevmartin/SEDO-Regular-Exam-2024-10.git', branch: 'feature-ci-pipeline'
            }
        }

        stage('Debug Branch Name') {
            steps {
                script {
                    echo "Current branch is: ${env.BRANCH_NAME}"
                }
            }
        }

        stage('Set up .NET') {
            steps {
                script {
                    // Verify the installed .NET version
                    sh 'dotnet --version' 
                }
            }
        }

        stage('Restore dependencies') {
            steps {
                // Restore the dependencies for the entire solution
                sh 'dotnet restore'
            }
        }

        stage('Build the application') {
            steps {
                // Build the application
                sh 'dotnet build --configuration Release --no-restore'
            }
        }

        stage('Run Unit Tests') {
            when {
                expression { 
                    // Run unit tests only on the 'feature-ci-pipeline' branch
                    return env.BRANCH_NAME == 'feature-ci-pipeline' 
                }
            }
            steps {
                // Run unit tests from the specific projects
                sh 'dotnet test HouseRentingSystem.UnitTests/HouseRentingSystem.UnitTests.csproj --no-restore --verbosity normal'
                sh 'dotnet test HouseRentingSystem.Tests/HouseRentingSystem.Tests.csproj --no-restore --verbosity normal'
            }
        }
    }
}
