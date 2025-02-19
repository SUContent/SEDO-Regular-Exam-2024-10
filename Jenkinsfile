pipeline {
    agent any

    environment {
        PATH = "/root/.dotnet:$PATH"
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Verify .NET Installation') {
            steps {
                sh 'dotnet --info'
            }
        }

        stage('Restore Dependencies') {
            steps {
                sh 'dotnet restore HouseRentingSystem.sln'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build --no-restore'
            }
        }

        stage('Run Tests') {
            steps {
                sh 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
