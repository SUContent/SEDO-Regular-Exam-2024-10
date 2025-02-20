pipeline {
    agent any
    environment {
        DOTNET_VERSION = '6.0.0'
    }
    stages {
        stage('Restore Dependencies') {
            steps {
                sh 'dotnet restore'
            }
        }
        stage('Build') {
            steps {
                sh 'dotnet build'
            }
        }
        stage('Run Tests') {
            steps {
                sh 'dotnet test'
            }
        }
    }
}





