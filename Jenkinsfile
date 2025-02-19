pipeline {
    agent any

    environment {
        DOTNET_VERSION = '6.0.0' 
    }

    stages {
     
        stage('Checkout Code') {
            steps {
                checkout scm
            }
        }

  
        stage('Setup .NET') {
            steps {
                script {
                  
                    bat 'curl -SL https://download.visualstudio.microsoft.com/download/pr/7907b54b-6c16-4b1f-bc6b-e7e199d295d7/78e1f99d09a6b59e6e77414e9d1a57cd/dotnet-sdk-6.0.0-win-x64.exe -o dotnet-sdk-installer.exe'
                    bat 'dotnet-sdk-installer.exe /quiet /norestart'
                }
            }
        }

      
        stage('Restore Dependencies') {
            steps {
                script {
                 
                    bat 'dotnet restore'
                }
            }
        }

       
        stage('Build Application') {
            steps {
                script {
                  
                    bat 'dotnet build --no-restore'
                }
            }
        }

        
        stage('Run Tests') {
            steps {
                script {
                    
                    bat 'dotnet test --no-build --logger "trx;LogFileName=test_results.trx"'
                }
            }
        }

     
        stage('Publish Test Results') {
            steps {
                junit '**/test_results.trx'
            }
        }
    }


    post {
        always {
            steps {
                echo "Cleaning up after build."
            }
        }

        success {
            echo "Build and tests passed successfully!"
        }

        failure {
            echo "Build or tests failed. Please check the logs!"
        }
    }
}
