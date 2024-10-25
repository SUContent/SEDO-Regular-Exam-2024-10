pipeline{
    agent any
     environment {
        TARGET_BRANCH = 'feature-ci-pipeline'
    }
    stages{
        stage('Checkout') {
            steps {
                script {
                    def branchName = env.BRANCH_NAME
                    if (branchName != TARGET_BRANCH) {
                        currentBuild.result = 'ABORTED'
                        error "Not on target branch ${TARGET_BRANCH}, stopping build."
                    }
                    checkout scm
                }
            }
        }
        stage("Build")
        {
            steps{
                bat 'dotnet build'
            }
        }
          stage("Run tests")
        {
            steps{
                bat 'dotnet tests C:\Users\lasss\Desktop\ExamPRep\HouseRentingSystem.UnitTests --no-build --verbosity normal'
            }
        }
    }
}