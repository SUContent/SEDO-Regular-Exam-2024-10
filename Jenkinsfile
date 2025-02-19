pipeline {
    agent { label 'windows' } // Specify Windows agent

    stages {
        stage('Checkout') {
            steps {
                checkout scm // Checkout the code from the repository
            }
        }

        stage('Restore Dependencies') {
            steps {
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build --no-restore --configuration Release'
            }
        }

        stage('Test') {
            steps {
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}

