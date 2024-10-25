pipeline {
    agent any
    stages {
        stage('Checkout code') {
            steps {
                git url: 'https://github.com/yourusername/yourrepo.git', branch: 'feature-ci-pipeline'
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
