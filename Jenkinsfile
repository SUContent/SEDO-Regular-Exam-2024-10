pipeline {
    agent any

    stages {
        stage('Checkout Repository') {
            steps {
                git branch: 'staging', url: 'https://github.com/YOUR_REPO.git'
            }
        }


        stage('Restore Dependencies') {
            steps {
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build --no-restore'
            }
        }

        stage('Run  Tests') {
            steps {
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
