pipeline {
    agent any

    environment {
        DOTNET_VERSION = '6.0.x' // Версия на .NET SDK
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm // Checkout на кода от Git
            }
        }

        stage('Setup .NET SDK') {
            steps {
                bat 'dotnet --version'
                bat 'dotnet --info'
                echo "Using .NET SDK version: ${env.DOTNET_VERSION}"
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

        stage('Run Unit Tests') {
            steps {
                bat 'dotnet test --no-build --verbosity normal --logger "trx;LogFileName=test-results.trx"'
            }
        }

        stage('Publish Test Results') {
            steps {
                step([
                    $class: 'JUnitResultArchiver',
                    testResults: '**/TestResults/*.trx', // Публикуване на резултати от тестовете
                    allowEmptyResults: true // Разрешава празни резултати, ако няма тестове
                ])
            }
        }
    }

    post {
        success {
            echo 'Pipeline completed successfully!'
        }
        failure {
            echo 'Pipeline failed!'
        }
    }
}
