pipeline {
    agent any  // Runs on any available agent (Windows or Linux)

    environment {
        DOTNET_VERSION = '6.0'  // Change to your required .NET version
        SOLUTION_FILE = 'HouseRentingSystem.sln'  // Update with your .NET solution file name
    }

    triggers {
        githubPush(branch: 'feature-ci-pipeline', triggerOnPush: true)  // Only triggers on this branch
    }
    stages {
        stage('Restore Dependencies') {
            steps {
                script {
                    echo '📦 Restoring NuGet packages...'
                    bat "dotnet restore ${SOLUTION_FILE}"
                }
            }
        }

        stage('Build Solution') {
            steps {
                script {
                    echo '🛠️ Building the project...'
                    bat "dotnet build ${SOLUTION_FILE} --configuration Release --no-restore"
                }
            }
        }

        stage('Run Tests') {
            steps {
                script {
                    echo '🧪 Running tests...'
                    bat "dotnet test ${SOLUTION_FILE} --logger trx --results-directory TestResults"
                }
            }
        }
    }

    post {
        always {
            archiveArtifacts artifacts: '**/TestResults/*.trx', allowEmptyArchive: true
            junit '**/TestResults/*.trx'
        }
        success {
            echo '✅ Build and Tests Passed Successfully!'
        }
        failure {
            echo '❌ Build or Tests Failed! Check logs.'
        }
    }
}
