pipeline {
  agent any
  stages {
    stage('Restore dependencies') {
      setps {
        bar 'dotnet restore'
      }
    }
    stage('Dotnet Build') {
      setps {
        bar 'dotnet build --no-restore'
      }
    }
    stage('Execute tests') {
      setps {
        bar 'dotnet test --no-build --verbosity normal'
      }
    }
  }
}
